import React, {Component, useState} from 'react';
import Menu from '../menu/menu';
const Four = () => {

  const [name,setName] = useState('')

  const vijay = () => {
    setName("Hi I am Vijay");
  }

  const deva = () => {
    setName("Hi I am Deva...");
  }

  const sai = () => {
    setName("Hi I am Sai...");
  }

  return(
    <div>
      <Menu />
      <input type="button" value="Vijay" onClick={vijay} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Deva" onClick={deva} /> 
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Sai" onClick={sai} />
      <hr/>
      Name is : <b>{name}</b>
    </div>
  )
}

export default Four;