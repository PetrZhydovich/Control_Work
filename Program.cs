string[] array =
{
    "aa",
    "bb",
    "vvvv",
    "ccccc",
    "fff",
    "dddd",
    "z"
};

var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}