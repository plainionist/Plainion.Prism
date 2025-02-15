// load dependencies from source folder to allow bootstrapping
#r "/bin/Plainion.CI/Fake.Core.Target.dll"
#r "/bin/Plainion.CI/Fake.Core.Trace.dll"
#r "/bin/Plainion.CI/Fake.IO.FileSystem.dll"
#r "/bin/Plainion.CI/Fake.IO.Zip.dll"
#r "/bin/Plainion.CI/Plainion.CI.Tasks.dll"

open Fake.Core
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Plainion.CI

Target.create "CreatePackage" (fun _ ->
    !! ( outputPath </> "*.*Tests.*" )
    ++ ( outputPath </> "*.Specs.*" )
    ++ ( outputPath </> "*nunit*" )
    ++ ( outputPath </> "TestResult.xml" )
    ++ ( outputPath </> "Plainion.RI.*" )
    ++ ( outputPath </> "**/*.pdb" )
    |> File.deleteAll

    [
        ( projectName + ".*", Some "lib/net8.0-windows", None)
    ]
    |> PNuGet.Pack (projectRoot </> "build" </> projectName + ".nuspec") (projectRoot </> "pkg")
)

Target.create "Deploy" (fun _ ->
    Trace.log "Nothing to deploy"
)

Target.create "Publish" (fun _ ->
    PNuGet.PublishPackage projectName (projectRoot </> "pkg")
)

Target.runOrDefault ""
