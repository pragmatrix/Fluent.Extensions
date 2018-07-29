msbuild=msbuild.exe /m /verbosity:m /nologo
nuget=nuget.exe

ver=2.0.2
name=Fluent.Extensions

.PHONY: package
package: conf=Release
package:
	cd ${name} && dotnet pack ${name}.csproj -c ${conf} /p:PackageVersion=${ver}

.PHONY: publish
publish: conf=Release
publish: package
	cd ${name}/bin/${conf} && ${nuget} push ${name}.${ver}.nupkg -source https://www.nuget.org/api/v2/package/

.PHONY: build-release
build-release: conf=Release
build-release: build

.PHONY: build
build:
	${msbuild} ${name}.sln /p:Configuration=${conf} /t:"Fluent_Extensions:Rebuild;Fluent_Extensions_Tests:Rebuild"

