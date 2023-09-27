const { obterPokemonA, obterPokemonB } = require('./request')

const main = async () => {
    const resultA = await obterPokemonA()
    const resultB = await obterPokemonB()

    const tiposDoA = resultA.types.map(el => el.type.name)
    const tiposDoB = resultB.types.map(el => el.type.name)

    console.log(`POKEMON A: ${resultA.species.name} | Tipo: ${tiposDoA} | Peso: ${resultA.weight}`)
    console.log(`POKEMON B: ${resultB.species.name} | Tipo: ${tiposDoB} | Peso: ${resultB.weight}`)

    if(tiposDoA[0] === 'water' && tiposDoB[0] === 'fire') {
      console.log('\nPOKEMON A TEM VANTAGEM COM O B')
    } else if(tiposDoA[0] === 'fire' && tiposDoB[0] === 'water') {
      console.log('\nPOKEMON B TEM VANTAGEM COM O A')
    }
}

main()