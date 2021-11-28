import React from 'react';
import { Button } from 'reactstrap';

const Home = () => {
  return (
    <div class="position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light">
      <div class="col-md-5 p-lg-5 mx-auto my-5">
        <h1 class="display-4 fw-normal">Snack React</h1>
        <p class="lead fw-normal">Take a break and react.</p>
        <Button>
          Coming Soon
        </Button>
      </div>
      <div class="product-device shadow-sm d-none d-md-block"></div>
      <div class="product-device product-device-2 shadow-sm d-none d-md-block"></div>
    </div>
  );
}

export default Home;
