# environment settings, adjust as needed
MONO=/usr/bin/mono
FSC=/opt/FSharp-2.0.0.0/bin/fsc.exe
NUNIT_BIN=/opt/NUnit-2.5.7.10213/bin/net-2.0

# ensure Mono finds NUnit
export MONO_PATH=${NUNIT_BIN}

# project settings
PDIR=HelloFSharp
FILES=${PDIR}/FsUnit.fs ${PDIR}/HelloWorld.fs ${PDIR}/Test.fs ${PDIR}/TestFsUnit.fs ${PDIR}/main.fs
MAIN=main.exe

${MAIN}: ${FILES}
	${MONO} ${FSC} -o $@ ${FILES} -r ${NUNIT_BIN}/nunit.framework.dll

run: ${MAIN}
	${MONO} ${MAIN}

test: ${MAIN}
	${MONO} ${NUNIT_BIN}/nunit-console.exe ${MAIN}

clean:
	rm -f ${MAIN} TestResult.xml *~
