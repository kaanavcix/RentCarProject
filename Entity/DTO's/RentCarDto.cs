using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO_s
{
    public class RentCarDto:CarDetailDto,IDto
    {

        public int Id { get; set; }
      
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; } //I WİLL ADJUST
    }
}
