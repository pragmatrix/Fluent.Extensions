msbuild=msbuild.exe /m /verbosity:m /nologo
nuget=nuget.exe

ver=2.0.0
name=Fluent.Extensions

.PHONY: publish
publish: package publish-nuget

.PHONY: package
package: conf=Release
package: build
	cd ${name} && ${nuget} pack ${name}.csproj -Version ${ver} -Prop Configuration=${conf} 
.PHONY: publish-nuget
publish-nuget: package
	cd ${name} && ${nuget} push ${name}.${ver}.nupkg -source https://www.nuget.org/api/v2/package/

.PHONY: build-release
build-release: conf=Release
build-release: build

.PHONY: build
build:
	${msbuild} ${name}.sln /p:Configuration=${conf} /t:"Fluent_Extensions:Rebuild;Fluent_Extensions_Tests:Rebuild"

