public class Solution {
    public int CountHousePlacements(int N) {
        int MOD = 1000000007;

        if (N == 1)
            return 4;

        // Initialize variables to count the ways of placing houses
        int withHouse = 1;
        int withoutHouse = 1;
        int prevWithHouse, prevWithoutHouse;

        for (int i = 2; i <= N; i++) {
            // Store previous values to update the counts for the current plot
            prevWithHouse = withHouse;
            prevWithoutHouse = withoutHouse;

            // Update the counts for the current plot
            withHouse = prevWithoutHouse;
            withoutHouse = (prevWithHouse + prevWithoutHouse) % MOD;
        }

        // Calculate the total number of ways for both sides of the street
        int totalWays = (withHouse + withoutHouse) % MOD;

        // Final result is (totalWays * totalWays) % MOD to handle large results
        int result = (totalWays * totalWays) % MOD;
        return result;
    }
}
