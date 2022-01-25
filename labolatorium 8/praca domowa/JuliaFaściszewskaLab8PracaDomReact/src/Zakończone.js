import React from 'react';

function Zakonczone(props) {
    return (
		<>
			<div className='card2' key={props.id}>
				ważne:<input type='checkbox' value={props.checked} onChange={props.onChange} />
				<div className={props.checked ? 'text-important' : ''}>{props.task}</div>
				<button className='btn_delete' onClick={props.onDelete}>
					Usuń
				</button>
			</div>
		</>
	);
}
export default Zakonczone;