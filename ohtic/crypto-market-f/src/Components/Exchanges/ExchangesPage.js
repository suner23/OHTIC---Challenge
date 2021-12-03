import React from "react";
import {Table} from 'react-bootstrap'

class ExchangesPage extends React.Component {

  constructor(props) {
    super(props);

    this.state = {
        items: [],
        DataisLoaded: false
    };
}

componentDidMount() {
    fetch(
      'https://localhost:5001/api/exchanges')
        .then((res) => {
          if (res.ok) {
            return res.json();
          } else {
            throw new Error('Something went wrong');
          }
        })
        .then((json) => {
            this.setState({
                exchanges: json,
                DataisLoaded: true
            });
        })
        .catch((error) => {
          console.log(error)
        });
}

  render() {
    const { DataisLoaded, exchanges } = this.state;
    if (!DataisLoaded) return <div>
        <h1> Pleses wait some time.... </h1> </div> ;
  return (
    <div>
      <h1>Exchanges Page</h1>
      <Table striped bordered hover variant="dark">
          <thead>
            <tr>
              <th id="exchangeName" variant="dark">Name</th>
              <th id="exchangeType" variant="dark">Type</th>
              <th id="exchangeTradingVolume" variant="dark">Trading Volume</th>
            </tr>
          </thead>
          <tbody>{
          exchanges.map((exchange) => ( 
          <tr key = { exchange.id } className="ElementRow">
              
                  <th id="coinName" variant="dark">{exchange.name}</th>
                  <th id="coinPrice" variant="dark">{exchange.type}</th>
                  <th id="coinMarketCap" variant="dark">{exchange.tradingVolume}</th>
              
              </tr>
          ))
          }</tbody>
        </Table>
    </div>
  );
  }
}

export default ExchangesPage;
