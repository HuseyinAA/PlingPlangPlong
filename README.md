# Pling! Plang! Plong!
## Application Goal

Write a function that takes as its input a number (`n`)  and converts it to a string, the contents of which depends on the numbers factors:

* if `n` has a factor of 3, output `Pling`
* if `n` has a factor of 5, output `Plang`
* if `n` has a factor of 7, output `Plong`
* if `n` is 0, output `PlingPlangPlong`
* if `n` does not have any of the above as a factor simply return the numbers digits

#### Example:

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple `Plong`
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a `PlingPlang`
- 34 only has a factors: 1, 2, 17 and 34: this would `34`

The application is fairly simple which allows for a number to be taken in and check if it is a factors of a number. The testing for this function can vary depending on the way the function is written.



### Testing

Following the Application goal the next stage was to test the function `PPPFactor` thoroughly making sure that the application is secure and well thought out.

##### Example:

````c#
public class FactorPlingPlangPlongTests
{
    private Raindrops _sut = new Raindrops();

    [TestCase(3, "Pling")]
    [TestCase(12, "Pling")]
    [TestCase(9, "Pling")]
    [TestCase(-9, "Pling")]
    public void Given_A_Value_With_Factor_Of_3_Return_Pling(int number, string expected)
    {
        Assert.AreEqual(expected, _sut.PPPFactor(number));
    }
````

Here is an example of a Test where the method is checking to see if `number` contains a `int` value that is actually a factor of 3 and if so then the `expected` will be compared with the string returned by the `_sut.PPPFactor(number)` method. The values are compared by test cases provided before the method. The `[TestCase(3, "Pling")]` attribute is what is being checked and fed to the test method to compare.

Ideally we would want to keep our tests clean as demonstrated above. But depending on the application the test cases can get complicated and confusing. That is why having method names as descriptive as they can be allows people to easily read and understand when looking through the tests. This is carried out throughout the test insuring no confusion or mistakes are caused.

Once completed the tests the results were clear that the function was able to withstand the different test cases and did not break.

##### Results:

![Test_Results](/Images/Test_Results.PNG)





