using UnityEngine;
using System.Threading.Tasks;
using Nethereum.Web3;

public class GetEther : MonoBehaviour
{
    private void Start()
    {
        GetEtherAsync();
    }

    static async Task GetEtherAsync()
    {
        var web3 = new Web3("https://mainnet.infura.io/v3/204ea08ed20846bfbcb270e264f3ec73");
        var balance = await web3.Eth.GetBalance.SendRequestAsync("0x2C6F2160942524fB94c67CbEd3635ECF00B0F4D8");
        Debug.Log(balance.Value);
    }
}
