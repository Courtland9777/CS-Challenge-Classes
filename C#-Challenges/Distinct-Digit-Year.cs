//Distinct Digit Year

public int DistinctDigitYear(int year)
{
	year++;
	while(year.ToString().Distinct().Count() != 4)
	{
	year++;
	}
	return year;
}