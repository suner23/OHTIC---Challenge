import './App.css';
import NavigationBar from './Components/Common/NavigationBar';
import {Route, Routes } from 'react-router-dom';
import CoinsPage from './Components/Coins/CoinsPage';
import ExchangesPage from './Components/Exchanges/ExchangesPage';
import * as React from 'react';

export default class App extends React.Component {
  render(){
  return (
    <div className="App">
        <NavigationBar></NavigationBar>
            <Routes>
             <Route path="/coins" element={<CoinsPage/>}/>
             <Route path="/exchanges" element={<ExchangesPage/>}/>
            <Route component={Error}/>
           </Routes>
    </div>
  );
}
}