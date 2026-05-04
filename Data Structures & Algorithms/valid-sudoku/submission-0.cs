public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[][] squares = new HashSet<char>[3][];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
        }

        for (int i = 0; i < 3; i++)
        {
            squares[i] = new HashSet<char>[3];
            for (int j = 0; j < 3; j++)
            {
                squares[i][j] = new HashSet<char>();
            }
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.') continue;

                char val = board[i][j];

                if (!rows[i].Add(val)) return false;
                if (!cols[j].Add(val)) return false;
                if (!squares[i / 3][j / 3].Add(val)) return false;
            }
        }

        return true;
    }
}