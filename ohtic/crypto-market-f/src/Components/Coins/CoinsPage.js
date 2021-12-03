import React from 'react';
import {Table} from 'react-bootstrap'

class CoinsPage extends React.Component{

    constructor(props) {
        super(props);
   
        this.state = {
            items: [],
            DataisLoaded: false
        };
    }
   
    componentDidMount() {
        fetch(
          'https://localhost:5001/api/coins')
            .then((res) => {
              if (res.ok) {
                return res.json();
              } else {
                throw new Error('Something went wrong');
              }
            })
            .then((json) => {
                this.setState({
                    coins: json,
                    DataisLoaded: true
                });
            })
            .catch((error) => {
              console.log(error)
            });
    }

    render() {
        const { DataisLoaded, coins } = this.state;
        if (!DataisLoaded) return <div>
            <h1> Pleses wait some time.... </h1> </div> ;
        return (
            <div>
                <h1>Coins Page</h1>
                <Table striped bordered hover variant="dark">
          <thead>
            <tr>
              <th id="coinName" variant="dark">Name</th>
              <th id="coinPrice" variant="dark">Price</th>
              <th id="coinMarketCap" variant="dark">MarketCap</th>
              <th id="coinTotalSupply" variant="dark">TotalSupply</th>
              <th id="coinMaxSupply" variant="dark">MaxSupply</th>
            </tr>
          </thead>
          <tbody>{
          coins.map((coin) => ( 
            
        <tr key = { coin.id }>
            
                <th id="coinName" variant="dark">{coin.name}</th>
                <th id="coinPrice" variant="dark">{coin.price}</th>
                <th id="coinMarketCap" variant="dark">{coin.marketCap}</th>
                <th id="coinTotalSupply" variant="dark">{coin.totalSupply}</th>
                <th id="coinMaxSupply" variant="dark">{coin.maxSupply}</th>
            
            </tr>
            
        ))
          }</tbody>
    </Table>
            </div>
          );
        }
}

export default CoinsPage;
 