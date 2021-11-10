# $expression = &"FizzBuzz_osx-x64 0 100 3 4";

$fizzbuzz = (3,5), (5,7), (7,9), (11,13)
$start = 0
$end = 1000

foreach($t in $fizzbuzz) {
  $fizz = $t.Get(0)
  $buzz = $t.Get(1)
  Start-Process `
    -FilePath "/Users/au299473/Workspace/hack-your-cs-education/code/scripting/FizzBuzz_osx-x64" `
    -ArgumentList $start, $end, $fizz, $buzz `
    -RedirectStandardOutput "$fizz-$buzz.out"
}