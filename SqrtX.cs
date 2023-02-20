public class Solution {
    public int MySqrt(int x) {
                int i = 1;
        long sq = i * i;
        while(x < sq) {
            i++;
            sq = i*i;
        }
        return i;
    }
}