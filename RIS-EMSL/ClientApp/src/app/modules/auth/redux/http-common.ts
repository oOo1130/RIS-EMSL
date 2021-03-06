import axios from "axios";

const API_URL = process.env.REACT_APP_API_URL

export default axios.create({
  baseURL: API_URL,
  headers: {
    "Content-type": "application/json",
    'Access-Control-Allow-Origin' : 'https://localhost:44318',
    'Access-Control-Allow-Headers' : '*',
    "Access-Control-Allow-Methods": "POST, GET, PUT, DELETE, DISPATCH, OPTIONS"
  }
});