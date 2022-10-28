using System.Collections.Generic;

namespace ExerciciosLeetCode
{
    public static class ImplementacaoLeetCode
    {
        public static int[] TwoSum(int[] nums, int target){
            // Ex: Nums: 2, 7, 11, 15 - Target: 9 
            var arrSet = new Dictionary<int,int>();
            int result = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                if (arrSet.ContainsKey((nums[i])))
                {
                    if (arrSet.TryGetValue((nums[i]), out result))                    
                        return new int[] { result, i };                    
                }else{
                    if(!arrSet.ContainsKey((target - nums[i]))) 
                       arrSet.Add((target - nums[i]), i);
                }
            }
            throw new System.Exception("Nenhum valor encontrado!"); 
        } 
    }
}
