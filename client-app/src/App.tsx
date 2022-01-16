import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(()=>{
    axios.get('http://localhost:5000/api/activities').then(response => {
      setActivities(response.data);
    })
  },[])

  return (
    <div>
      <Header as='h2' icon='users' content='WaterPlant'/>
        <List>
          {activities.map((activity:any) => (
              <li key={activity.id}>
                {activity.date}
              </li>
            ))}
        </List>
    </div>
  );
}

export default App;
