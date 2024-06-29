using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "Y";
        string innerLoop = " ";

        List<Scripture> _scripture = new List<Scripture>();

        Scripture temp1 = new Scripture("articles of faith", 1, 1, "We believe in God, the Eternal Father, and in His Son, Jesus Christ, and in the Holy Ghost.");
        Scripture temp2 = new Scripture("articles of faith", 1, 2, "We believe that men will be punished for their own sins, and not for Adam’s transgression.");
        Scripture temp3 = new Scripture("articles of faith", 1, 3, "We believe that through the Atonement of Christ, all mankind may be saved, by obedience to the laws and ordinances of the Gospel.");
        Scripture temp4 = new Scripture("articles of faith", 1, 4, "We believe that the first principles and ordinances of the Gospel are: first, Faith in the Lord Jesus Christ; second, Repentance; third, Baptism by immersion for the remission of sins; fourth, Laying on of hands for the gift of the Holy Ghost.");
        Scripture temp5 = new Scripture("Moroni", 10, 3, 6, "3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. \n 4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n 4 And by the power of the Holy Ghost ye may know the truth of all things.");

        _scripture.Add(temp1);
        _scripture.Add(temp2);
        _scripture.Add(temp3);
        _scripture.Add(temp4);
        _scripture.Add(temp5);
        do
        {
            int count = 1;
            Console.Clear();
            Console.WriteLine("Type Q at anytime to quit");
            Console.WriteLine("Which scripture would you like to work on today?");
            foreach (Scripture s in _scripture)
            {
                Console.WriteLine($"{count++}. {s.GetReference()}");
            }


            input = Console.ReadLine();

            int userSelect = int.Parse(input);

            do
            {
                Console.Clear();
                _scripture[userSelect - 1].DisplayScripture();
                innerLoop = Console.ReadLine();

            } while (innerLoop != "Q" && !_scripture[userSelect - 1].IsScriptureHidden());
            Console.WriteLine("Do you want to do another one? (Y/N)");
            input = Console.ReadLine();
        } while (input == "Y");
    }

}
// _scripture.Add("");
// _scripture.Add();
// _scripture.Add();
// _scripture.Add("5 We believe that a man must be called of God, by prophecy, and by the laying on of hands by those who are in authority, to preach the Gospel and administer in the ordinances thereof.");
// _scripture.Add("6 We believe in the same organization that existed in the Primitive Church, namely, apostles, prophets, pastors, teachers, evangelists, and so forth.");
// _scripture.Add("7 We believe in the gift of tongues, prophecy, revelation, visions, healing, interpretation of tongues, and so forth.");
// _scripture.Add("8 We believe the Bible to be the word of God as far as it is translated correctly; we also believe the Book of Mormon to be the word of God.");
// _scripture.Add("9 We believe all that God has revealed, all that He does now reveal, and we believe that He will yet reveal many great and important things pertaining to the Kingdom of God.");
// _scripture.Add("10 We believe in the literal gathering of Israel and in the restoration of the Ten Tribes; that Zion (the New Jerusalem) will be built upon the American continent; that Christ will reign personally upon the earth; and, that the earth will be renewed and receive its paradisiacal glory.");
// _scripture.Add("11 We claim the privilege of worshiping Almighty God according to the dictates of our own conscience, and allow all men the same privilege, let them worship how, where, or what they may.");
// _scripture.Add("12 We believe in being subject to kings, presidents, rulers, and magistrates, in obeying, honoring, and sustaining the law.");
// _scripture.Add("13 We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men; indeed, we may say that we follow the admonition of Paul—We believe all things, we hope all things, we have endured many things, and hope to be able to endure all things. If there is anything virtuous, lovely, or of good report or praiseworthy, we seek after these things.");
