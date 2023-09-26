Dimensional weight is a pricing model that shows the amount of space a package occupies compared to its actual weight. It reflects package density and is calculated as shown below:

Step 1: Determine the package measurement in inches
Measure the package's length, width, and height.

Step 2: Multiply the package length by the width by the height
Length x Width x Height = Cubic Volume

Step 3: Divide the cubic size by the divisor
Divide the cubic volume (in inches) by a divisor to determine the dimensional weight in pounds.
For UPS Daily Rates, the divisor is 139.

The shipping rate is then calculated using either the total actual weight, or the total dimensional weight of the package - whichever is great. The formula for that calculation is as follows:

```C#
(Weight * $1.89 (price per lb)) + $10 (initial shipping cost)
```