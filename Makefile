clean:
	-find -type d -name bin -exec rm -rf {} \;
	-find -type d -name obj -exec rm -rf {} \;


compile: clean 
	nuget restore Orion.sln
	xbuild /p:Configuration=Release Orion.sln

test: 
	nuget install NUnit.Runners -Version 3.4.1 -OutputDirectory tools
	mono ./tools/NUnit.Console.3.4.1/tools/nunit3-console.exe ./Orion.Tests/bin/Release/Orion.Tests.dll

coverageconfig:
	./tools/ContinuousIntegration/Build/generateCoverageConfig.sh > ./coverageConfig.json

instrument: coverageconfig
	mono ./tools/SharpCover/SharpCover.exe instrument ./coverageConfig.json

coverage: compile instrument test
	-mono ./tools/SharpCover/SharpCover.exe check