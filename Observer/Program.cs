using Observer;
using Observer.Observers;

Stock stock = new Stock();

var bank = new Bank(stock);
var broker = new Broker(stock);

stock.Market();

broker.StopTrade();

stock.Market();