function iqTest(numbers){
  // split the string into array by space
  let parts = numbers.split(' ');
  let evenness0 = +parts[0] % 2;
  let evenness1 = +parts[1] % 2;

  for (let i = 2; i < parts.length; i++)
  {
      let evenness = +parts[i] % 2;
      if (evenness0 == evenness1)
      {
          if (evenness != evenness0)
              return i + 1;
      }
      else
      {
          if (evenness != evenness0)
              return 1;
          else
              return 2;
      }
  }

  return 0;
}