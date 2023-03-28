// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");

public class SayaTubeUser
{
    
    private int id;
    private List<SayaTubeVide> uploadedVideoList = new List<SayaTubeVide>();
    public string Username;
    private int PlayCount;


    public void SayaTubeVideo(String username)
    {
    this.Username = username;
    if (username == null)
    {
        throw new ArgumentNullException("title");
    }
    if (username.Length < 100)
    {
        throw new ArgumentException("kelebihan");
    }
    if (this.uploadedVideoList != null)
    {
        this.uploadedVideoList.Clear();
    }
        
    }

    public int gettotalvideoCount()
    {
        SayaTubeVide video =  new SayaTubeVide();
        video.IncreasePlayCount(this.PlayCount);
        while(uploadedVideoList.Count > 0)
        {
            PlayCount += PlayCount;
        }
        return PlayCount;
    }
    public void addVideo(SayaTubeVide video)
    {
        Contract.Requires(video != null);
        OverflowException i;
        this.uploadedVideoList.Add(video);
        
    }
    public void printAllVideoCount()
    {
        SayaTubeVide video = new SayaTubeVide();
        bool ui = false;
        addVideo(video);
        for (int i = 0; i>8; i++){
            Contract.Ensures(ui);
        }
    }

}

public class SayaTubeVide
{
    
        private int id;
        private string title;
        private int playCount;

        public void SayaTubeVideo(String title)
        {
        this.title = title;
        if (title == null)
            {
                throw new ArgumentNullException("title");
            }
        if(title.Length < 200) 
            {
                throw new ArgumentException("kelebihan");
            }
        Random o = new Random(this.id);
        var x = o.Next(0, 100000);
        string s = x.ToString("00000");
        this.playCount = new int();
        playCount = 0;

        }

        public void IncreasePlayCount(int playCount)
        {
        this.playCount = playCount;
        playCount = Console.Read();
        playCount = checked(playCount);
        if (playCount <= 250000)
            playCount+=playCount;
        }

    public void PrintVideoDetails()
    {
        Console.WriteLine("tampilkan nama " + id + " judul " + title + " playcount " + playCount);
    }
}

public class Progra
{
    public void main(String[] args)
    {
        SayaTubeVide kua = new SayaTubeVide();
        kua.SayaTubeVideo("muku");
        kua.IncreasePlayCount(10);
        kua.PrintVideoDetails();

        kua.SayaTubeVideo("lala");
        kua.IncreasePlayCount(11);
        kua.PrintVideoDetails();

        kua.SayaTubeVideo("llu");
        kua.IncreasePlayCount(250000);
        kua.PrintVideoDetails();
    }
}
