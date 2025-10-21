namespace Lab_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // 当爱心按钮被点击时，这个方法会被调用
        private void OnFavoriteClicked(object sender, EventArgs e)
        {
            // 这里我们弹出一个提示框来证明按钮被点击了
            DisplayAlert("Favorite", "You have added this pet to your favorites!", "OK");
        }
    }
}