using CalendarApp.Entites;


Meeting meeting1 = new()
    {
        Title = "Yetgen Jump Backend Planlama Toplantısı",
        Details = "Önemli konular konuşulacak",
        StartTime = new DateTime(2023, 09, 17),
        EndTime = new DateTime(2023, 09, 17),
        Guests = new() { "elif.baykara@deneme.com" },

    };
Todo todo1 = new()
    {
        Title = "Katılımcı Geri Bildirimleri",
        Details = "Önemli konular konuşulacak",
        StartTime = new DateTime(2023, 09, 17),
        EndTime = new DateTime(2023, 09, 17),
        Importance = "High Priority",

    };
meeting1.GetNotification();
todo1.GetNotification();
  
 


