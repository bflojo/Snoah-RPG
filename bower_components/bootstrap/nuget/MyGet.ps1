<<<<<<< HEAD
$nuget = $env:NuGet

#parse the version number out of package.json
$bsversion = ((Get-Content $env:SourcesPath\package.json) -join "`n" | ConvertFrom-Json).version

#create packages
& $nuget pack "nuget\bootstrap.nuspec" -Verbosity detailed -NonInteractive -NoPackageAnalysis -BasePath $env:SourcesPath -Version $bsversion
=======
$nuget = $env:NuGet

#parse the version number out of package.json
$bsversion = ((Get-Content $env:SourcesPath\package.json) -join "`n" | ConvertFrom-Json).version

#create packages
& $nuget pack "nuget\bootstrap.nuspec" -Verbosity detailed -NonInteractive -NoPackageAnalysis -BasePath $env:SourcesPath -Version $bsversion
>>>>>>> 1891c8b9f5096b714cb15914533b2cee0e9d567b
& $nuget pack "nuget\bootstrap.less.nuspec" -Verbosity detailed -NonInteractive -NoPackageAnalysis -BasePath $env:SourcesPath -Version $bsversion