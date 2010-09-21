# environment settings, adjust as needed
MONO=/usr/bin/mono
FSC=/opt/FSharp-2.0.0.0/bin/fsc.exe
NUNIT_BIN=/opt/NUnit-2.5.7.10213/bin/net-2.0

# project settings
PDIR=HelloFSharp
FILES=${PDIR}/FsUnit.fs ${PDIR}/HelloWorld.fs ${PDIR}/Test.fs ${PDIR}/TestFsUnit.fs ${PDIR}/main.fs
MAIN=main.exe

compile: ${FILES}
	${MONO} ${FSC} -o ${MAIN} ${FILES} -r ${NUNIT_BIN}/nunit.framework.dll

run: compile
	${MONO} ${MAIN}

test: compile
	${MONO} ${NUNIT_BIN}/nunit-console.exe ${MAIN}

clean:
	rm ${MAIN}
