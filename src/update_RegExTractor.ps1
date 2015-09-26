# Catching command line arguments
param([string]$RegExTractorSolutionDir)

# Define variables

$PublishPath = $RegExTractorSolutionDir + "\Publish"

$StagePath = $PublishPath + "\Staging"
$CdonsoleStagePath = $StagePath + "\RegExTractorConsole"
$WinFormStagePath = $StagePath + "\RegExTractorWinForm"

$DestinationPath = ".\NppRegExTractor\RegExTractor"


# Copy RegExTractorWinForm components
Copy-Item $WinFormStagePath\Ninject.dll -Destination $DestinationPath
Copy-Item $WinFormStagePath\RegExTractor.dll -Destination $DestinationPath
Copy-Item $WinFormStagePath\RegExTractorModules.dll -Destination $DestinationPath
Copy-Item $WinFormStagePath\RegExTractorShared.dll -Destination $DestinationPath
Copy-Item $WinFormStagePath\RegExTractorWinForm.dll -Destination $DestinationPath



$file = $WinFormStagePath + "\RegExTractor.dll"
$ass = [System.Reflection.Assembly]::LoadFile($file)
$v = $ass.GetName().Version;
$version = [string]::Format("{0}.{1:0}.{2:0}",$v.Major, $v.Minor, $v.Build)

Invoke-Expression "./SetVersion.ps1 $version"
Write-Host "Updated version to $version"

Invoke-Expression ".\build.cmd"

Invoke-Expression "./publish.ps1 $(get-location)"
