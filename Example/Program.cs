using DoubleSharp.Progress;

var sum = Enumerable.Range(0, 1000).ToList().WithProgress().Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
var sum2 = Enumerable.Range(0, 1000).ToList().WithProgress(true).Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
var sum3 = Enumerable.Range(0, 1000).WithProgress().Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
var sum4 = Enumerable.Range(0, 10000).ToList().WithProgress(true).AsParallel().Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
var sum5 = Enumerable.Range(0, 10000).ToArray().WithProgress().AsParallel().Select(x => {
	Thread.Sleep(1);
	return x;
}).Sum();
var sum6 = Enumerable.Range(0, 1000).ToList().WithTimedProgress().Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
var sum7 = Enumerable.Range(0, 1000).ToList().WithTimedProgress(true).Select(x => {
	Thread.Sleep(3);
	return x;
}).Sum();
