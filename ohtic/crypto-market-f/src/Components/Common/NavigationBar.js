import {Navbar, Container, Nav} from 'react-bootstrap'

function NavigationBar() {
  return (
      <div>
        <h1 id="Title">Coin prices</h1>
        <Navbar bg="light" expand="lg">
        <Container>
            <Navbar.Brand href="/coins">      
            <img
            src="/logoBitcoin.png"
            width="30"
            height="30"
            className="d-inline-block align-top"
            alt="React Bootstrap logo"/>
            Coin prices</Navbar.Brand>
            <Navbar.Toggle aria-controls="basic-navbar-nav" />
            <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
                <Nav.Link href="/coins">Coins</Nav.Link>
                <Nav.Link href="/exchanges">Exchanges</Nav.Link>
            </Nav>
            </Navbar.Collapse>
        </Container>
        </Navbar>
      </div>
  );
}
export default NavigationBar;

