async function postData(url = '') {
    const response = await fetch(url);
    return response.text(); 
}


function GetFilteredItems() {
    const container = document.getElementById("container");
    postData('Item/GetFilteredItems/1') //I want to get items with the MyProperty3 value bigger than 1
        .then((data) => {
            container.innerHTML = data;
        });

}