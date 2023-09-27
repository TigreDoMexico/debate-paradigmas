const axios = require('axios');

const urlCharizard = 'https://pokeapi.co/api/v2/pokemon/charizard'
const urlBlastoise = 'https://pokeapi.co/api/v2/pokemon/blastoise'

const obterPokemonA = async () => {
    try {
        const response = await axios.get(urlCharizard)
        return response.data;
    } catch (error) {
        console.log(error);
        return null;
    }
}

const obterPokemonB = async () => {
    try {
        const response = await axios.get(urlBlastoise)
        return response.data;
    } catch (error) {
        console.log(error);
        return null;
    }
}

module.exports = {
    obterPokemonA,
    obterPokemonB
};
