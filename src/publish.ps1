# Catching command line arguments
param([string]$SolutionDir)

# Define variables

$PublishPath = $SolutionDir + "\Publish"

$StagePath = $PublishPath + "\Staging"
$WinFormStagePath = $StagePath + "\RegExTractor"
$NppPluginDllStagePathStagePath = $StagePath

$ReleaseDir = $SolutionDir + "\NppRegExTractor\bin\Debug"


$ZipPath = $PublishPath + "\ZIP"


# Remove previous data
Remove-Item -Path $PublishPath -Recurse -Force

# Recreate folders
New-Item -ItemType Directory -Force -Path $NppPluginDllStagePathStagePath
New-Item -ItemType Directory -Force -Path $WinFormStagePath
New-Item -ItemType Directory -Force -Path $ZipPath

# Copy NppPlugin DLL
Copy-Item $ReleaseDir\NppRegExtractorPlugin.dll -Destination $NppPluginDllStagePathStagePath

# Copy RegExTractorWinForm
Copy-Item $ReleaseDir\RegExTractor\Ninject.dll -Destination $WinFormStagePath
Copy-Item $ReleaseDir\RegExTractor\RegExTractor.dll -Destination $WinFormStagePath
Copy-Item $ReleaseDir\RegExTractor\RegExTractorModules.dll -Destination $WinFormStagePath
Copy-Item $ReleaseDir\RegExTractor\RegExTractorShared.dll -Destination $WinFormStagePath
Copy-Item $ReleaseDir\RegExTractor\RegExTractorWinForm.dll -Destination $WinFormStagePath


$file = $ReleaseDir + "\RegExTractor\RegExTractor.dll"
$ass = [System.Reflection.Assembly]::LoadFile($file)
$v = $ass.GetName().Version;
$version = [string]::Format("{0}.{1:0}.{2:0}",$v.Major, $v.Minor, $v.Build)

$ZipFile = $ZipPath + "\NppRegExTractor_V" + $version + ".zip"
Get-ChildItem -Path $StagePath | Compress-Archive -DestinationPath $ZipFile -Verbose