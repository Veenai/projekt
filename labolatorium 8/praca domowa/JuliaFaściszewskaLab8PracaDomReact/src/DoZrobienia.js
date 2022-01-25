import React from 'react';

function DoZrobienia(props) {
    return (
		<>
			<div className='card' key={props.id}>
				ważne:<input type='checkbox' value={props.checked} onChange={props.onChange} />
				<div className={props.checked ? 'text-important' : ''}>{props.task}</div>
				<button className='btn' onClick={props.onMove}>
					Przenieś do zaczętych
				</button>
				<button className='btn_delete' onClick={props.onDelete}>
					Usuń
				</button>
			</div>
		</>
	);
}
export default DoZrobienia;