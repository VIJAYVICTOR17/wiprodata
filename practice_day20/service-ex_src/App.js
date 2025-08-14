import logo from './logo.svg';
import './App.css';
import UserShow from './components/usershow/usershow';
import UserSearch from './components/usersearch/usersearch';
import EmployAdd from './components/employAdd/employAdd';
import EmploySearch from './components/employsearch/employsearch';
import EmployShow from './components/employshow/employshow';

function App() {
  return (
    <div className="App">
      <UserShow/>
      <UserSearch/>
      <EmploySearch/>
      <EmployAdd/>
      <EmployShow/>
    </div>
  );
}

export default App;
