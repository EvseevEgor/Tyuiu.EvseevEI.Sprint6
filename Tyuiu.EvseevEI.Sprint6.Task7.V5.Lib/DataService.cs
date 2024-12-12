using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EvseevEI.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            string[] fileList = file.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int rows = fileList.GetLength(0);
            int cols = fileList[0].Split(';').GetLength(0);
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(fileList[i].Split(';')[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, cols - 1] < 2) matrix[i, cols - 1] = 2;
            }
            return matrix;
        }

    }
}
