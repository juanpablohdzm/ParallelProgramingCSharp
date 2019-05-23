using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
  public partial class MainFrame : Form
  {
    public MainFrame()
    {
      InitializeComponent();
    }

    //public int CalculateValue()
    //{
    //  Thread.Sleep(5000);
    //  return 123;
    //}

    public async Task<int> CalculateValueAsync()
    {
      //return Task.Factory.StartNew(() =>
      //{
      //  Thread.Sleep(5000);
      //  return 123;
      //});

      await Task.Delay(5000);
      //Thread.Sleep(5000);
      return 123;
    }

    // ConfigureAwait()
    // for a library, always use ConfigureAwait(false)

    private async void BtnCalculate_Click(object sender, EventArgs e)
    {
      //int n = CalculateValue();
      //LblResult.Text = n.ToString();

      //var calculation = CalculateValueAsync();
      //calculation.ContinueWith(t =>
      //{
      //  LblResult.Text = t.Result.ToString();
      //}, TaskScheduler.FromCurrentSynchronizationContext());
      // we want this code to look like ordinary, sync code

      // notice calculation is an int
      int value = await CalculateValueAsync();
      //          ^^^^^ does not block; instead, everything else is a continuation

      // why did this work? because we captured the synchronization context
      // now try ConfigureAwait(false)

      LblResult.Text = value.ToString();
      await Task.Delay(5000);
      
      Task.Factory.StartNew(async () =>
      {
        
      })

      //
      var wc = new WebClient();
      string data = await wc.DownloadStringTaskAsync("http://google.com/robots.txt");
      LblResult.Text = data.Split('\n')[0].Trim();
    }
  }
}

// If we want to use something like Task.WaitAll/WaitAny
// we can use Task.WhenAny() or Task.WhenAll()

//Task.Run is a shortcut that calls Task.Factory.StartNew() and Unwrap()s the result
//For example,
//int result  = await Task.Run(async
// delegate)
// {
// await Task.Delay(1000);
// return 42;
//)}; The type of result is an int just as you would expect
