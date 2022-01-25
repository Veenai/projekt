import React from 'react';

function WTrakcie(props) {
    return (
		<>
			<div className='card1' key={props.id}>
				ważne:<input type='checkbox' value={props.checked} onChange={props.onChange} />
				<div className={props.checked ? 'text-important' : ''}>{props.task}</div>
				<button className='btn' onClick={props.onMove}>
					Przenieś do zakończonych
				</button>
				<button className='btn_delete' onClick={props.onDelete}>
					Usuń
				</button>
			</div>
		</>
	);
}
export default WTrakcie;