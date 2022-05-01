using Business.Abstract;
using Business.Constants;
using Business.DependencyReolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.TR
{
    public partial class frmProductPointRatingTR : Form
    {
        public frmProductPointRatingTR()
        {
            InitializeComponent();
            myProductSevice = InstanceFactory.GetInstance<IMyProductSevice>();
            gameDataService = InstanceFactory.GetInstance<IGameDataService>();
        }
        public int GetAccountId;
        public int GetInventory;
        public int GetGameDataId;
        public string GetUsername;
        public string GetPhoneName;
        public decimal totalcost;
        decimal ProductSalesGain;

        Random ratingRandom = new Random();
        Random commentRandom = new Random();

        List<string> GoodComment = new List<string>() { MessagesTR.GoodComment1, MessagesTR.GoodComment2, MessagesTR.GoodComment3 };
        List<string> BadComment = new List<string>() { MessagesTR.BadComment1, MessagesTR.BadComment2, MessagesTR.BadComment3 };

        int rating1;
        int rating2;
        int rating3;
        int rating4;

        IMyProductSevice myProductSevice;
        IGameDataService gameDataService;

        string GetComment(int rating)
        {

            if (rating >= 3)
            {
                var getIndex = commentRandom.Next(0, GoodComment.Count);
                var getComment = GoodComment[getIndex];
                return getComment;
            }
            else
            {
                var getIndex = commentRandom.Next(0, BadComment.Count);
                var getComment = BadComment[getIndex];
                return getComment;

            }
        }
        void ShowComment()
        {

            rating1 = ratingRandom.Next(0, 6);
            rating2 = ratingRandom.Next(0, 6);
            rating3 = ratingRandom.Next(0, 6);
            rating4 = ratingRandom.Next(0, 6);


            lblPointRating1.Text = rating1.ToString();
            var getComment1 = GetComment(int.Parse(lblPointRating1.Text));
            lblComment1.Text = getComment1;

            lblPointRating2.Text = rating2.ToString();
            var getComment2 = GetComment(int.Parse(lblPointRating2.Text));
            lblComment2.Text = getComment2;

            lblPointRating3.Text = rating3.ToString();
            var getComment3 = GetComment(int.Parse(lblPointRating3.Text));
            lblComment3.Text = getComment3;

            lblPointRating4.Text = rating4.ToString();
            var getComment4 = GetComment(int.Parse(lblPointRating4.Text));
            lblComment4.Text = getComment4;

            lblPhoneName.Text = GetPhoneName;
        }

        void UpdateGameData()
        {
            var data = myProductSevice.GetGameDataById(GetGameDataId).Data;
            int xp = data.Xp;
            decimal cash = data.Money;
            cash += ProductSalesGain;
            xp += 100;

            data.Money = cash;
            data.Xp = xp;
            gameDataService.UpdateData(data);
            myProductSevice.levelsytem(GetGameDataId);


        }
        void UpdateMyProduct()
        {
            var product = myProductSevice.GetProductById(GetPhoneName).Data;

            ProductSalesGain = (totalcost / 3) - (totalcost / 8);
            decimal avgReting = (rating1 + rating2 + rating3 + rating4) / 4;

            product.ProductSalesGain = ProductSalesGain;
            product.AveragePoint = avgReting;

            var check = avgReting > 3
               ? true : false;
            product.BestProduct = check;
            myProductSevice.UpdateProduct(product);
        }

        private void frmProductPointRatingTR_Load(object sender, EventArgs e)
        {
            ShowComment();
            UpdateMyProduct();
            UpdateGameData();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmGameScreenTR frmGameScreen = new frmGameScreenTR();
            frmGameScreen.GetAccountId = GetAccountId;
            frmGameScreen.GetGameData = GetGameDataId;
            frmGameScreen.GetInventory = GetInventory;
            frmGameScreen.GetUsername = GetUsername;
            frmGameScreen.Show();
            this.Close();
        }
    }
}
