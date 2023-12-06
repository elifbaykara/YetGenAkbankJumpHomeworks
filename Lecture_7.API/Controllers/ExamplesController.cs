using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lecture_7.API.Controllers
{
    [Route("api/[controller]")]  //route dediğimiz ne ? ==> url'e yazdığımız ve o endpointe gittiğimiz yerler oluyor. localhost:5611/api/contollerinadı yani bizimki examples =>  localhost/api/examples 
    [ApiController]
    public class ExamplesController : ControllerBase  
    {
        // burası sadece bir sınıf, içine aksiyon(işlem) eklemem gerek.
        [HttpGet("[action]")]
        public string TrimText(string text)  //bu bir metot!!!! METOTLAR SADECE CLASSLARIN İÇİNE YAZILABİLİR --AYRICA fonksiyonlar public private gibi erişim belirleyiciler almazlar. --Fonksiyonlar da metotlar da büyük harfle başlamalıdır !!!!!!!!!!!!!
        {  //
            return text.Trim();
        }

        //query olanda query yazar, route olanda path yazar   !!
        [HttpGet("[action]")]
        public string UpperText([FromBody]string text)  //fromroute yazınca url'de açık açık gözüküyor ama frombody yazınca gözükmüyor. Onu gizliyor örneğin password yazsak açık açık görünür from route yazınca ama bu frombody yazınca gizleniyor. Fakat eğer frombody kullanacaksak httpget kullanılmaz, httppost kullanabiliriz.
        { 
            return text.ToUpper();
        }
    }
}
