import { Link } from "react-router-dom";
import { Col, Container, Row } from "reactstrap";

const Footer = () => {
    return (
        <footer>
            <Container className="py-5">
                <Row>
                    <Col xs="12">
                        <small className="d-block mb-3 text-muted">&copy; 2021</small>
                    </Col>
                    <Col xs="6"></Col>
                    <Col xs="6"></Col>
                    <Col xs="6"></Col>
                    <Col xs="6">
                        <h5>About</h5>
                        <ul className="list-unstyled text-small">
                            <li><Link to="/about">About Us</Link></li>
                        </ul>
                    </Col>
                </Row>
            </Container>
        </footer>
    );
}

export default Footer;
