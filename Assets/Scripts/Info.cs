using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public GameObject infoPanel;
    public Sprite[] planetSprites;
    public List<string> planetInfoList = new List<string>();

    public Image planetImage;
    public TextMeshProUGUI planetInfo;

    private int actualPlanet = 0;
    void Start()
    {
        planetInfoList.Add("- Name: Sun\r\n- Size: Diameter of approximately 1,392,700 km\r\n- Rotation speed: About 2 km/s (rotation period of 25–35 days)\r\n- Average surface temperature: Around 5,500 °C\r\n- Type: Yellow dwarf star (G-type)");
        planetInfoList.Add("- Name: Mercury\r\n- Size: Diameter of 4,879 km\r\n- Rotation speed: 10.9 km/h\r\n- Orbital speed: 172,404 km/h\r\n- Distance from the Sun: 57.9 million km");
        planetInfoList.Add("- Name: Venus\r\n- Size: Diameter of 12,104 km\r\n- Rotation speed: 6.5 km/h (retrograde rotation)\r\n- Orbital speed: 126,074 km/h\r\n- Distance from the Sun: 108.2 million km");
        planetInfoList.Add("- Name: Earth\r\n- Size: Diameter of 12,742 km\r\n- Rotation speed: 1,670 km/h\r\n- Orbital speed: 107,280 km/h\r\n- Distance from the Sun: 149.6 million km");
        planetInfoList.Add("- Name: Moon (Earth's Satelite)\r\n- Size: Diameter of 3,474 km\r\n- Rotation speed: 16.7 km/h (rotation period of 27.3 days)\r\n- Orbital speed (around Earth): 3,683 km/h\r\n- Distance from the Earth: About 384,400 km");
        planetInfoList.Add("- Name: Mars\r\n- Size: Diameter of 6,779 km\r\n- Rotation speed: 868 km/h\r\n- Orbital speed: 86,677 km/h\r\n- Distance from the Sun: 227.9 million km");
        planetInfoList.Add("- Name: Jupiter\r\n- Size: Diameter of 139,820 km\r\n- Rotation speed: 45,300 km/h\r\n- Orbital speed: 47,051 km/h\r\n- Distance from the Sun: 778.5 million km");
        planetInfoList.Add("- Name: Saturn\r\n- Size: Diameter of 116,460 km\r\n- Rotation speed: 36,840 km/h\r\n- Orbital speed: 34,821 km/h\r\n- Distance from the Sun: 1,433 million km");
        planetInfoList.Add("- Name: Uranus\r\n- Size: Diameter of 50,724 km\r\n- Rotation speed: 14,794 km/h (rotates on its side)\r\n- Orbital speed: 24,477 km/h\r\n- Distance from the Sun: 2,872 million km");
        planetInfoList.Add("- Name: Neptune\r\n- Size: Diameter of 49,244 km\r\n- Rotation speed: 9,719 km/h\r\n- Orbital speed: 19,566 km/h\r\n- Distance from the Sun: 4,495 million km");
        planetInfoList.Add("- Name: Pluto (Dwarf Planet)\r\n- Size: Diameter of 2,377 km\r\n- Rotation speed: 47 km/h\r\n- Orbital speed: 17,096 km/h\r\n- Distance from the Sun: 5,906 million km");

        refreshInfo();
    }

    public void refreshInfo()
    {
        planetImage.sprite = planetSprites[actualPlanet];
        planetInfo.text = planetInfoList[actualPlanet];
    }

    public void forward()
    {
        if (actualPlanet + 1 >= planetInfoList.Count)
        {
            actualPlanet = 0;
        }else
        {
            actualPlanet++;
        }

        refreshInfo();
    }

    public void backward()
    {
        if (actualPlanet - 1 >= -1)
        {
            actualPlanet = planetInfoList.Count-1;
        }
        else
        {
            actualPlanet--;
        }

        refreshInfo();
    }
    void Update()
    {
        
    }

    public void activateInfoPanel()
    {
        infoPanel.SetActive(!infoPanel.activeSelf);
    }



}
