clean:
	-find -type d -name bin -exec rm -rf {} \;
	-find -type d -name obj -exec rm -rf {} \;
	
compile: clean 
	nuget restore Orion.sln
	xbuild /p:Configuration=Release Orion.sln	

coverageconfig:
	sudo ./tools/ContinuousIntegration/Build/generateCoverageConfig.sh > ./coverageConfig.json

instrument: coverageconfig
	mono ./tools/SharpCover/SharpCover.exe instrument ./coverageConfig.json

coverage: compile instrument
	-mono ./tools/SharpCover/SharpCover.exe check
