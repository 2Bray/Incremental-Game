using System.Collections.Generic;


//Agar Object Dapat Disimpan Menjadi String Dan Diload Kembali
[System.Serializable]

public class UserProgressData
{
    public double Gold = 0;
    public List<int> ResourcesLevels = new List<int>();
}