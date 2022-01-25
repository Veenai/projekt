import DoZrobienia from './DoZrobienia';
import WTrakcie from './WTrakcie';
import Zakonczone from './Zakończone';

import React, { useState, useEffect } from 'react';
import './App.css';

function App() {
  //tablica z zadaniami do zrobienia
  const [toDo, setToDo] = useState([{ checked: false, task: 'Zadanie 1' }]);
  //tablica z zadaniami w trakcie
  const [doing, setDoing] = useState([]);
  //tablica z zadaniami zakończonymi
  const [done, setDone] = useState([]);
  //zadania
	const [task, setTask] = useState('');

  useEffect(() => {
		document.title = 'Zakończyłeś tle zadań: ' + done.length;
	}, [done]);

	const handleInput = function (event) {
		setTask(event.target.value);
	};
	const handleClick = function () {
		setToDo([...toDo, { checked: false, task: task }]);
	};
 // zmiana ważności zadań do zrobienia
	const handleChange = function (index) {
		return (event) => {
			const newtoDo = [...toDo];
			newtoDo[index].checked = event.target.checked;
			setToDo(newtoDo);
		};
	};
  // zmiana ważności zadań w trakcie
  const handleChangeDoing = function (index) {
		return (event) => {
			const newdoing = [...doing];
			newdoing[index].checked = event.target.checked;
			setDoing(newdoing);
		};
	};
  // zmiana ważności zadań zakończonych
  const handleChangeDone = function (index) {
		return (event) => {
			const newdone = [...done];
			newdone[index].checked = event.target.checked;
			setDone(newdone);
		};
	};
//przeniesienie z do zrobienia na w trakcie
  const handleMoveDoing = function (index) {
		return (event) => {
      const newdoing=[...doing,toDo[index]]
      setDoing(newdoing);
      const newtoDo = toDo.filter((element, i, arr) => {
				return i !== index;
			});
			setToDo(newtoDo);
		};
  };
  //przeniesieniez z w trakcie do zakończone
  const handleMoveDone = function (index) {
		return (event) => {
      const newdone=[...done,doing[index]]
      setDone(newdone);
      const newdoing = doing.filter((element, i, arr) => {
				return i !== index;
			});
			setDoing(newdoing);
		};
  };
  //usuwanie zadań z do zrobienia
	const handleDelete = function (index) {
		return () => {
			const newtoDo = toDo.filter((element, i, arr) => {
				return i !== index;
			});
			setToDo(newtoDo);
		};
	};
    //usuwanie zadań z w trakcie
  const handleDeleteDoing = function (index) {
		return () => {
			const newdoing = doing.filter((element, i, arr) => {
				return i !== index;
			});
			setDoing(newdoing);
		};
	};
    //usuwanie zadań z do zrobienia
  const handleDeleteDone = function (index) {
		return () => {
			const newdone = done.filter((element, i, arr) => {
				return i !== index;
			});
			setDone(newdone);
		};
	};


	return (
		<div className='App'>
			<header className='App-header'><h1>Zarządzaj swoimi zadaniami jak mistrz!</h1></header>
			<div>
				<input className='input' placeholder='Wpisz swoje zadanie' onInput={handleInput} />
				<button className='btn' onClick={handleClick}>
					Dodaj zadanie
				</button>
        <h2>DO ZROBIENIA</h2>
				<div className='container'>
					{toDo.map(function (elementFromTable, index) {
						return (
							<DoZrobienia
								key={index}
								id={index}
								checked={elementFromTable.checked}
								onChange={handleChange(index)}
								onMove={handleMoveDoing(index)}
                onDelete={handleDelete(index)}
								task={elementFromTable.task}
							/>
						);
					})}
				</div>
        <h2>W TRAKCIE</h2>
        <div className='container'>
					{doing.map(function (elementFromTable, index) {
						return (
							<WTrakcie
								key={index}
								id={index}
								checked={elementFromTable.checked}
								onChange={handleChangeDoing(index)}
								onMove={handleMoveDone(index)}
                onDelete={handleDeleteDoing(index)}
								task={elementFromTable.task}
							/>
						);
					})}
				</div>
        <h2>ZAKOŃCZONE</h2>
        <div className='container'>
					{done.map(function (elementFromTable, index) {
						return (
							<Zakonczone
								key={index}
								id={index}
								checked={elementFromTable.checked}
								onChange={handleChangeDone(index)}
								onDelete={handleDeleteDone(index)}
								task={elementFromTable.task}
							/>
						);
					})}
				</div>
			</div>
		</div>
	);
  
}

export default App;
