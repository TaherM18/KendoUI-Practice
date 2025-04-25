import { config } from "/js/modules/config.js";

//

const defaultRequestOptions = {
    method: "GET",
    redirect: "follow"
};

async function safeFetch(url, requestOptions = defaultRequestOptions) {
    try {
        const response = await fetch(url, requestOptions);
        if (!response.ok) throw new Error(`HTTP ${response.status}`);
        const json = await response.json();
        return json.data;
    } catch (error) {
        console.error("Fetch error:", error);
        return [];
    }
}

// Exports

export async function fetchStates() {
    return await safeFetch(`${config.origin}/api/state`);
}

export async function fetchCities() {
    return await safeFetch(`${config.origin}/api/city`);
}

export async function fetchCitiesByState(stateCode) {
    return await safeFetch(`${config.origin}/api/city/state/${stateCode}`)
}