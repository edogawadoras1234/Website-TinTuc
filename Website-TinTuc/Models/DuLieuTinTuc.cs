using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Website_TinTuc.Models
{
    public class DuLieuTinTuc : DropCreateDatabaseAlways<DinhNghiaTinTuc>
    {
        protected override void Seed(DinhNghiaTinTuc context)
        {
            GetTacgias().ForEach(c => context.Tacgias.Add(c));
            GetTinTucs().ForEach(p => context.Tintucs.Add(p));
        }
        private static List<TacGia> GetTacgias()
        {
            var categories = new List<TacGia> {
                new TacGia
               {
                 TGia_ID = 1,
                 TenTG = "vnexpress",
                 Email = "vnexpress@email.com"
                 },
                 new TacGia
                 {
                 TGia_ID = 2,
                 TenTG = "vietnammoi",
                 Email = "vietnammoiegmail.com"
                 },
                 new TacGia{
                 TGia_ID= 3,
                 TenTG = "dantri",
                 Email = "dantri@email.com"
                 },
                 new TacGia{
                 TGia_ID= 4,
                 TenTG = "24h",
                 Email = "24h@email.com"
                 },
                 };
            return categories;
        }
        private static List<TinTuc> GetTinTucs()
        {
            var books = new List<TinTuc> {

                 new TinTuc
                 {
                 Tin_ID = 1,
                 NoiDung = "Khá không kêu oan, chỉ kháng cáo xin giảm nhẹ hình phạt 4 năm tù về tội" +
                    "Đánh bạc, 6 năm 6 tháng tù do Tổ chức đánh bạc, lãnh đạo TAND thị xã Từ Sơn cho biết, chiều 9/12." +
                    "Bốn đồng phạm còn lại cũng kháng cáo xin giảm nhẹ hình phạt." +
                    "Tại phiên sơ thẩm mở giữa tháng 11, Khá bị TAND thị xã Từ Sơn phạt 10 năm 6 tháng tù về tội Đánh bạc và Tổ chức đánh bạc." +
                    "Bị toà đánh giá có vai trò giúp sức tích cực, Nguyễn Hữu Hội (30 tuổi) nhận án 3 năm 6 tháng tù về tội Đánh bạc và 5 năm về tội Tổ chức đánh bạc, tổng cộng" +
                    "8 năm 6 tháng tù; Nguyễn Văn Quang (32 tuổi) lĩnh 5 năm tù về tội Tổ chức đánh bạc; Trịnh Hữu Quý (27 tuổi) 12 tháng tù; Ngô Lương An (34 tuổi) 20" +
                    "tháng tù và Nguyễn Trọng Công (26 tuổi) 15 tháng tù cùng về tội Đánh bạc." +
                    "Bản án xác định, từ ngày 10/1 đến 1/4, Khá tổ chức đánh bạc bằng hình thức" +
                    "chơi số lô, đề, chủ yếu giao dịch qua tin nhắn điện thoại và tài khoản mạng xã hội mang tên Khá Bảnh",
                 NgayGui = "22/12/2019",
                 HinhAnh ="../Images/kha-banh.jpg",
                 TGia_ID = 1
                 },

                 new TinTuc
                 {
                 Tin_ID = 2,
                 NoiDung ="NGHỆ AN - Nguyễn Thị Doan (47 tuổi, trú huyện Đô Lương) bị tạm giữ với cáo" +
                    "buộc đã ném chăn, cầm chân dốc ngược, cư xử thô bạo với bé Trâm Anh 14 tháng tuổi." +
                    "Ngày 9/12, bà Doan bị Công an thành phố Vinh (Nghệ An) điều tra về hành vi Hành hạ người khác, điều 140, Bộ luật Hình sự 2015." +
                    "Bà Doan nói hối hận những gì đã gây ra với nạn nhân, khai do bức xúc nhất thời nên làm vậy. cán bộ công an cho biết." +
                    "Trước khi bị tạm giữ, trả lời VnExpress, bà Doan kể tối 4/12 cho Trâm Anh bú bình xong thì đưa lên giường ru ngủ như thường lệ nhưng bé bị trớ, liên tục " +
                    "khóc. 'Tôi lau chùi sạch sẽ để bé ngủ nhưng không có kết quả nên cầm chăn úp lên người rồi túm chân dốc ngược. Tất cả chỉ nhằm mục đích cho ngủ. Giờ " +
                    "tôi biết mình đã sai và rất muốn được gia đình bé tha thứ...', bà Doan nói và" +
                    "cho biết do đông con cháu nên rất hiểu công việc chăm sóc trẻ.",
                 NgayGui = "23/1/2019",
                 HinhAnh ="../Images/tre-14.jpg",
                 TGia_ID = 2
                 },

                 new TinTuc
                 {
                 Tin_ID = 3,
                 NoiDung = "Vi Văn Khay (trú huyện Con Cuông) bị cáo buộc đã cấu kết với người khác đưa 3 cô gái ở miền núi sang Trung Quốc." +
                    "Ngày 14/12, Khay đang bị Công an huyện Kỳ Sơn (Nghệ An) khởi tố, bắt tạm giam về hành vi Mua bán người." +
                    "Theo cơ quan điều tra, năm 2016 Vi Văn Khay cấu kết với Can Thị Mơ là một phụ nữ Việt Nam đang sinh sống tại Trung Quốc để tìm các cô gái trẻ người Việt Nam đưa sang Trung Quốc." +
                    "Tháng 3/2016, Khay đón xe khách, đưa ba cô gái trẻ ra Móng Cái (Quảng Ninh) giao cho người của Mơ. Từ đây, ba cô gái bị đưa vượt biên sang Trung Quốc và bị bán cho người bản địa để làm vợ với giá khoảng 70 triệu đồng mỗi người." +
                    "Khay được Mơ trả 20 triệu tiền công và hứa một năm sau sẽ trả tiếp 10 triệu. Sau thời gian sinh sống ở Trung Quốc, tháng 11 vừa qua hai nạn nhân trong số này đã trở về Việt Nam tố cáo hành vi của Khay.",
                    HinhAnh ="../Images/thanhnien.jpg",
                 NgayGui = "14/12/2019",
                 TGia_ID = 3
                 },
                 new TinTuc
                 {
                 Tin_ID = 4,
                 NoiDung = "Khi Kathleen Sagusti báo có án mạng xảy ra, cảnh sát không tin vì cô vừa là gái bán dâm, vừa là người nghiện ma tuý. " +
                    "Tại phòng cảnh sát thành phố Easton, bang Pennsylvania vào ngày 5/8/1996, Kathleen trình báo bị hai gã đàn ông chuyên bán ma túy Corey Maeweather và Kwame Henry đâm bị thương ở tay sau khi đôi co." +
                    " Kathleen còn tiết lộ một tuần trước, Corey, Kwame cùng Stanley Obas đã đem cô gái da màu 19 tuổi tên Materon Smith tới nhà mình vì nghi ăn trộm số cocaine trị giá 2.000 USD." +
                    "Sau khi Corey và Kwame kéo Materon xuống tầng hầm, Kathleen nghe thấy tiếng khóc lóc của Materon nhưng bị Stanley ngăn không cho xuống. Khoảng 40 phút sau, tiếng van xin chấm dứt, ba gã đàn ông sau đó cùng khuân chiếc thùng các-tông rời đi. Materon cũng biến mất từ đó.",
                    HinhAnh ="../Images/keo-cao-su.jpg",
                    NgayGui = "12/3/2019",
                 TGia_ID = 4
                 },
                 };
            return books;
        }
    }
}