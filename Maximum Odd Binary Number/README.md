2864. Maximum Odd Binary Number

### Problem Description

You are given a binary string s that contains at least one '1'.
You have to rearrange the bits in such a way that the resulting binary number is the maximum odd binary number that can be created from this combination.
Return a string representing the maximum odd binary number that can be created from the given combination.
Note that the resulting string can have leading zeros.

### Examples

#### Example 1:

**Input:** 
```
s = "010"
```

**Output:** 
```
"001"
```

**Explanation:** 
Because there is just one '1', it must be in the last position. So the answer is "001".

#### Example 2:

**Input:** 
```
s = "0101"
```

**Output:** 
```
"1001"
```

**Explanation:** 
One of the '1's must be in the last position. The maximum number that can be made with the remaining digits is "100". So the answer is "1001".

### Constraints

- 1 <= s.length <= 100
- s consists only of '0' and '1'.
- s contains at least one '1'.

### Intuition

The approach aims to construct the maximum odd binary number by counting the number of ‘1’s in the input string. By appending ‘1’s (onesCount - 1 times), followed by ‘0’s (N - onesCount times), and finally appending a ‘1’, the result is guaranteed to be the maximum odd binary number.

### Approach

1. Count the number of occurrences of ‘1’ in the input string.
2. Use a StringBuilder to efficiently construct the result by appending ‘1’s (onesCount - 1 times), ‘0’s (N - onesCount times), and a final ‘1’.
3. Return the resulting string.

### Complexity

- **Time complexity:** 
O(N), where N is the length of the input string.
- **Space complexity:** 
O(N) due to the use of a StringBuilder to store the resulting string. The StringBuilder’s capacity is proportional to the length of the resulting string, which is at most N.

### Key Points

- The resulting string can have leading zeros.
- The result is constructed by appending ‘1’s (onesCount - 1 times), ‘0’s (N - onesCount times), and a final ‘1’.
- Efficiently construct the result using a StringBuilder.
- Ensure that the input string contains at least one '1'.