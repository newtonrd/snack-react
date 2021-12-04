import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from './NavMenu';
import Footer from './Footer';

const Layout = (props) => {
  return (
    <div>
      <NavMenu />
      <main>
        <Container>
          {props.children}
        </Container>
      </main>
      <Footer />
    </div>
  );
}

export default Layout;
