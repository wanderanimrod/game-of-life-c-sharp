#! /bin/sh

function ut {
    mono packages/xunit.runner.console.2.1.0/tools/xunit.console.exe Test/bin/Debug/Test.dll
}

$@
