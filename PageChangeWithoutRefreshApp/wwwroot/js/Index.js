async function postData(url = '') {
    const response = await fetch(url);
    return response.text(); 
}


function GetFilteredItems() {
    const container = document.getElementById("container");
    postData('Item/GetFilteredItems/1')
        .then((data) => {
            container.innerHTML = data;
        });

}