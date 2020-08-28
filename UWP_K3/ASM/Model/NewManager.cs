using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Model
{
    public class NewManager
    {
        public static void GetAllNews(ObservableCollection<New> news)
        {
            var allNews = getNews();
            news.Clear();
            allNews.ForEach(p => news.Add(p));

        }

        public static List<New> getNews()
        {
            var news = new List<New>();
            news.Add(new New("1", NewCategory.Gaming, "Messi và cuộc đấu trí cam go ở Barca: Toan tính thâm sâu, ai đang có lợi thế?", "Hợp đồng của Messi ban đầu có điều khoản ngày hết hạn để anh đệ đơn ra đi là 30/6. Đây là cột mốc thường thấy trong hợp đồng của các cầu thủ bóng đá, là thời điểm đôi bên bắt đầu gia hạn hoặc chia tay. Tuy nhiên, do ảnh hưởng của đại dịch Covid-19 trong năm nay, các giải đấu đã phải kéo dài thêm 3 tháng."));
            news.Add(new New("2", NewCategory.Entertainment, "Bom tấn 200 triệu USD cho đâm máy bay thật công bố hậu trường kịch tính", "Bom tấn được đầu tư 200 triệu USD của đạo diễn tài ba Christopher Nolan - TENET đã chính thức “lên kệ”. Hãng Studio Warner Bros. cũng lập tức công bố đoạn phim hậu trường “nóng hổi vừa thổi vừa ăn” của TENET."));
            news.Add(new New("3", NewCategory.Productivity, "Sập trần công trình xây dựng đại lý ô tô ở thành phố Bắc Giang", "Theo thông tin ban đầu, sự việc xảy ra vào khoảng 20h30 ngày 27/8 tại công trình xây dựng đại lý ô tô ở khu đô thị phía Nam xã Tân Tiến, thành phố Bắc Giang (Bắc Giang). Trao đổi với Tiền Phong, ông Mai Sơn, Bí thư thành phố Bắc Giang xác nhận có sự việc trên. Trong ảnh: CSGT phong tỏa hiện trường đảm bảo an toàn."));
            news.Add(new New("4", NewCategory.Deal, "5 dịch bệnh kỳ lạ từng khiến các nhà khoa học phải đau đầu", "Các nhà nghiên cứu đã thực hiện một cuộc điều tra tìm hiểu nguyên nhân bùng phát một số căn bệnh kỳ lạ. Trong một số trường hợp, nhiều năm hay thậm chí là cả nhiều thập kỷ trôi qua, họ vẫn chưa tìm ra câu trả lời. Sau đây là một số bí ẩn khoa học đáng chú ý mà các nhà nghiên cứu vẫn đang bế tắc không rõ nguyên nhân."));
 

            return news;
        }

        public static void GetByCategory(ObservableCollection<New> news, NewCategory newsCategory)
        {
            var allNews = getNews();
            var filteredNews = allNews.Where(p => p.Category == newsCategory).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }
    }
}
