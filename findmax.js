function FindMax(numbers) {
  if (numbers.length == 0) {
    return -1;
  }

  var max = numbers[0];

  for (var i = 0; i < numbers.length; i++) {
    if (numbers[i] > max) {
      max = numbers[i];
    }
  }

  return max;
}

var a = [1, 2, 3, 4, 5, -1, 33, -5];
console.log(FindMax(a));

