 // 冒泡排序
            int[] arraylist = new int[] { 2,4,8,5,3,1};
            for(int i=0; i<arraylist.Length;i++)
            {
                for (int j=i+1; j<arraylist.Length;j++)
                {
                    if (arraylist[i]>arraylist[j])
                    {
                        int number = arraylist[i];
                        arraylist[i] = arraylist[j];
                        arraylist[j] = number;
                    }
                }
            }
            int[] arrlist2 = arraylist;