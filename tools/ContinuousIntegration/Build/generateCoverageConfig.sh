ASSEMBLIES=`find Tests -type f -name Orion.dll | grep -v /obj/ | grep -v Tests.dll | perl -e '@in=grep(s/\n$//, <>); print "[\"".join("\", \"", @in)."\"],\n";'`
echo "{"
echo "  \"assemblies\": ${ASSEMBLIES}" 
echo "  \"typeInclude\": \"Orion.*\"," 
echo "  \"typeExclude\": \"Orion.*Tests*\""
echo "}"
