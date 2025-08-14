import React, {Component} from 'react';
import Menu from '../menu/menu';
const ButtonEx = () => {

  const vijay = () => {
    alert("Hi I am Vijay...");
  }

  const deva = () => {
    alert("Hi i am Deva...");
  }

  const sai = () => {
    alert("Hi I am Sai...");
  }

  return(
    <div>
      <Menu />
      <input type="button" value="Vijay" onClick={vijay} /> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Deva" onClick={deva} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Sai" onClick={sai} />
    </div>
  )
} 

export default ButtonEx;